chcp 65001

REM 參考
REM https://blog.miniasp.com/post/2020/08/07/EF-Core-31-Code-First-DB-Migration-set-collation
REM https://ithelp.ithome.com.tw/articles/10240606

REM 先移除先前測試出來的 Migrations 和資料庫
rd /S /Q .\Migrations
dotnet ef database drop -f

REM 建立初始化資料庫移轉設定
dotnet ef migrations add init --context ApiContext

REM 更新資料庫（如果沒有資料庫，將會自動建立全新資料庫）
dotnet ef database update --context ApiContext

REM 執行專案
dotnet run