V11 OF A VAST SET OF SOFTWARE SPANNING ENTERPRISE NETWORK MANAGEMENT
INCLUDES A PORT OF CSCE590 CODE TO POSTGRESQL AND A NEW V2.0 HTML PORTAL.

Linux Repository

Connection string for Remodeling:

//Current API String to be compliant with other CockyEnteprises Products -> Just the tables you want....

 dotnet ef dbcontext scaffold "Host=dbserver.590team1.info;Username=postgres;Password=*Columbia1;Database=gem" Npgsql.EntityFrameworkCore.PostgreSQL --context-namespace Enterprise.Models -o Models --namespace Enterprise.Models -f --no-build --table gmanagers --table gemployees --table ghregions --table gbregions --table gbranches --table gsites --table gchange --table gapps --table gusers --table gusers_cards

//Current API String as it exists

 dotnet ef dbcontext scaffold "Host=dbserver.590team1.info;Username=postgres;Password=*Columbia1;Database=gem" Npgsql.EntityFrameworkCore.PostgreSQL --context-namespace GemAPI.Models -o Models --namespace GemAPI.Models -f --no-build 

//The no build simply updates the models, it does not update the VS update. This can be important, as the compilation step is not reversible. (You overwrote your old build).

//NODE3 EXAMPLE - ADDING WP 9.04 NpgSQL driver has different naming syntax.
dotnet ef dbcontext scaffold "Host=gliops.glocation.info;Port=5434;Username=gridsa;Password=test12345;Database=gemwp" Npgsql.EntityFrameworkCore.PostgreSQL -o ModelsGEMWP --context-dir Data --no-build
