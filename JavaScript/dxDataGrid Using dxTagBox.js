$('#div-id').dxDataGrid({
    editing: {
        mode: 'batch',
        allowUpdating: true,
        allowAdding: true,
        allowDeleting: true,
        selectTextOnEditStart: true,
        startEditAction: 'click'
    },
    onEditorPreparing: function(e) {
        const tagBoxColumns = ['column1', 'column2']
        if ((e.parentType === "dataRow" || e.parentType === "filterRow") && tagBoxColumns.includes(e.dataField)) {
            const currnetRow = tagBoxes.find(column => column.name === e.dataField)
            e.editorName = "dxTagBox"
            e.editorOptions.dataSource = currnetRow.list
            e.editorOptions.showSelectionControls = true
            e.editorOptions.displayExpr = "show_text" //currnetRow.text
            e.editorOptions.valueExpr = "value"
            e.editorOptions.value = e.value || []
            e.editorOptions.onValueChanged = function(args) {
                e.setValue(args.value)
            }
        }
    },
    columns: [{
            dataField: "column1",
            calculateDisplayValue: function(rowData) {
                var filterExpression = [],
                    values = rowData?.column1 //*
                if (!values) {
                    return ''
                }
                for (var i = 0; i < values.length; i++) {
                    if (i > 0) {
                        filterExpression.push('or')
                    }
                    filterExpression.push(['value', values[i]]) //*list.value column's name
                }
                var result = $.map(DevExpress
                    .data
                    .query(column1s) //*
                    .filter(filterExpression)
                    .toArray(),
                    function(item) {
                        return item.text
                    }).join(',')
                return result
            },
            calculateFilterExpression: function(filterValues, selectedFilterOperation) {
                return function(itemData) {
                    var array1 = itemData.value
                    var array2 = filterValues

                    if (array2.length === 0)
                        return true

                    return array1.length === array2.length && array1.every(function(value, index) { return value === array2[index] })
                }
            }
        },
        {
            dataField: "column2",
            calculateDisplayValue: function(rowData) {
                var filterExpression = [],
                    values = rowData?.column2 //*
                if (!values) {
                    return ''
                }
                for (var i = 0; i < values.length; i++) {
                    if (i > 0) {
                        filterExpression.push('or')
                    }
                    filterExpression.push(['value', values[i]]) //*list.value column's name
                }
                var result = $.map(DevExpress
                    .data
                    .query(column2s) //*
                    .filter(filterExpression)
                    .toArray(),
                    function(item) {
                        return item.show_text //list.text column's name
                    }).join(',')
                return result
            },
            calculateFilterExpression: function(filterValues, selectedFilterOperation) {
                return function(itemData) {
                    var array1 = itemData.value
                    var array2 = filterValues

                    if (array2.length === 0)
                        return true

                    return array1.length === array2.length && array1.every(function(value, index) { return value === array2[index] })
                }
            }

        },
        "other_column"
    ]
})


const column1s = [
    { id: 1, value: 1, show_text: '產品退回' },
    { id: 2, value: 2, show_text: '樣品退回' },
    { id: 3, value: 3, show_text: '錄影描述' },
    { id: 4, value: 4, show_text: '相片描述' },
    { id: 5, value: 5, show_text: '其他' }
]
const column2s = [
    { id: 1, value: 1, show_text: '進料檢驗' },
    { id: 2, value: 2, show_text: '製程裝配檢驗' }
]
const tagBoxes = [
    { name: 'column1', list: column1s, text: 'show_text' },
    { name: 'column2', list: column2s, text: 'show_text' }
]