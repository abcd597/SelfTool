# Handle API result format and error message  
  
## Example:  
### 1.Success:
```csharp
[ErrorFilter]
[ParameterFilter]
[HttpPost]
public ActionResult DoSomething(string parameter1,string parameter2)
{
   /*DoSomething*/
   //returnData=...
   return Json(returnData, JsonRequestBehavior.AllowGet);
}
```  
### 2.Error:
```csharp
[ErrorFilter]
[ParameterFilter]
[HttpPost]
public ActionResult DoSomething(string parameter1,string parameter2)
{
   /*DoSomething*/
   if(wrong){
   throw new Exception("Error Message"); 
   }
   return ...
}
```
