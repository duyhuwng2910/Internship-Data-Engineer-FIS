﻿dotnet ef dbcontext scaffold  "data source=192.168.20.200;initial catalog=dwe;persist security info=True;user id=TTS_Data;password=1234567;multipleactiveresultsets=True;" Microsoft.EntityFrameworkCore.SqlServer -c DWEContext  -o DWEModels -f --no-build --use-database-names --json
$content = Get-Content -Path 'DWEModels\DWEContext.cs' -Encoding UTF8