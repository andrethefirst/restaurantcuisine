# MVCToDoListNetCoreMySQL

1. Import the database in the 'sql' folder within ToDoList into MySQL Workbench. ***Use the schema name 'to_do_list'.***
2. Add appsettings.json in ToDoList:

```json
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=to_do_list;uid=root;pwd=password;"
  }
}
```

1. dotnet run.
