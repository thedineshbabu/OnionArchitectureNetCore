# OnionArchitectureNetCore
OnionArchitectureNetCore

##Docker Container DB

docker run --cap-add SYS_PTRACE -e 'ACCEPT_EULA=1' -e 'MSSQL_SA_PASSWORD={passwordß}' -p 1433:1433 --name azuresqledge -d mcr.microsoft.com/azure-sql-edge