
--//Rename//

--sp_rename 'EmployeeInfo.new1', 'newcol', 'COLUMN'

execute sp_rename 
@objname=N'[dbo].[EmployeeInfo].[new]', 
@newname=N'year', 
@objtype=N'COLUMN';