CREATE TABLE [dbo].[EmployeeInfo] (
    [EmpNo]       INT          IDENTITY (1, 1) NOT NULL,
    [EmpName]     VARCHAR (50) NOT NULL,
    [DeptName]    VARCHAR (50) NOT NULL,
    [Designation] VARCHAR (50) NOT NULL,
    [Salary]      DECIMAL (18) NOT NULL,
    year        INT          NULL,
    PRIMARY KEY CLUSTERED ([EmpNo] ASC)


);



