CREATE OR ALTER PROCEDURE RunningProcedureMVC
    @TaskName NVARCHAR(50) -- Receives the task name
AS
BEGIN
    DECLARE @progress INT = 0;

    -- Insert the process
    INSERT INTO Processes (TaskName, ProgressPercent, LastUpdated)
    VALUES (@TaskName, 100, GETDATE());

END;