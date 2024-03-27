steps to run API

1.delete Migration folder in Infrastructure folder in inital pull
2.change server name to your sql server in appsetting.json in MoiveStore.API
3.move to folder path MovieStore in terminal and type 
	dotnet ef migrations add InitialMigration --project MoivesStore.Infrastructure --startup-project MoivesStore.API
4.then update DB with this
	dotnet ef database update --project MoivesStore.Infrastructure --startup-project MoivesStore.API
5.run the app