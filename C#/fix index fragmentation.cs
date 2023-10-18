 /*
using System;
using System.Data.SqlClient;
using System.Linq;
using System.Web.Configuration;

 */


 string sql = @"
  SELECT t.name,'ALTER INDEX [' + ix.name + '] ON [' + s.name + '].[' + t.name + '] ' +
CASE
       WHEN ps.avg_fragmentation_in_percent > 15
       THEN '{0};'--REBUILD
       ELSE '{0};'--REORGANIZE
END +
CASE
       WHEN pc.partition_count > 1
       THEN ' PARTITION = ' + CAST(ps.partition_number AS nvarchar(MAX))
       ELSE ''
END 'action',
avg_fragmentation_in_percent
 FROM   sys.indexes AS ix
INNER JOIN sys.tables t
ON     t.object_id = ix.object_id
INNER JOIN sys.schemas s
ON     t.schema_id = s.schema_id
INNER JOIN
       (SELECT object_id                   ,
               index_id                    ,
               avg_fragmentation_in_percent,
               partition_number
       FROM    sys.dm_db_index_physical_stats (DB_ID(), NULL, NULL, NULL, NULL)
       ) ps
ON     t.object_id = ps.object_id
   AND ix.index_id = ps.index_id
INNER JOIN
       (SELECT  object_id,
                index_id ,
                COUNT(DISTINCT partition_number) AS partition_count
       FROM     sys.partitions
       GROUP BY object_id,
                index_id
       ) pc
ON     t.object_id              = pc.object_id
   AND ix.index_id              = pc.index_id
 WHERE  ps.avg_fragmentation_in_percent > 10
 AND ix.name IS NOT NULL;
 ";
 string rebuildSql=string.Format(sql, "REBUILD");
 string reorganize = string.Format(sql, "REORGANIZE");
 var rebuildResult = csSqlComm.doSelectListCommandDapper<index_maintenance>(rebuildSql).ToList();
 var reorganizeResult= csSqlComm.doSelectListCommandDapper<index_maintenance>(reorganize).ToList();
 string allRebuildActionSql = rebuildResult.Select(item => item.action).Aggregate((final,current)=>$"{final}{current}");
 string allReorganizeActionSql= reorganizeResult.Select(item => item.action).Aggregate((final, current) => $"{final}{current}");
 using (var connection = new SqlConnection(WebConfigurationManager.ConnectionStrings["ConnectionString"].ToString()))
 {
     connection.Open();

     using (var transaction = connection.BeginTransaction())
     {
         // Dapper Execute
         var affectedRebuildRows = connection.Execute(allRebuildActionSql, transaction: transaction);
         var affectedReorganizeRows = connection.Execute(allReorganizeActionSql, transaction: transaction);
         transaction.Commit();
     }
 }
