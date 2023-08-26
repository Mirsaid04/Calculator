namespace Calculator.Classes;

  internal interface IReportingContract
  {
      public  void ShowGratitude();
      public  void ReportProgress(string messages);
      public  void ReportResult(string result);
  }
