
# MovieStore API

This is Backend application with REST API and clean architecture and repository pattern

### Steps to run API

Delete Migration folder in Infrastructure folder in inital pull

Change server name to your sql server in appsetting.json in MoiveStore.API


## Migration

Move to folder path MovieStore in terminal and type 

```bash
  dotnet ef migrations add InitialMigration --project MoivesStore.Infrastructure --startup-project MoivesStore.API
```
Then update DB with this
```bash
	dotnet ef database update --project MoivesStore.Infrastructure --startup-project MoivesStore.API
```
Run the app
