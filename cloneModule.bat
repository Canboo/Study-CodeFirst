chcp 65001

REM 移除CityModule
rd /S /Q .\Modules\CityModule

REM git clone Study-CodeFirst-Nuget 到 Modules
git clone https://github.com/Canboo/Study-CodeFirst-Nuget.git ./Modules
rmdir Modules\.git /S /Q

REM 更新資料庫（如果沒有資料庫，將會自動建立全新資料庫）
Modules\CityModule\migrations.bat