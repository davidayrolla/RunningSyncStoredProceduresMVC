namespace RunningSyncStoredProceduresMVC.Models
{
    public class Process
    {
        public int ProcessId { get; set; }

        public string? TaskName { get; set; }

        public int ProgressPercent { get; set; }

        public DateTime? LastUpdated { get; set; }

        public Process()
        {
            TaskName = null;
            ProgressPercent = 0;
            LastUpdated = null;
        }        

    }
}
