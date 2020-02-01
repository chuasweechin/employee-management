namespace EmployeeManagement.Mediator
{
  public interface IMediatorService
  {
    void Notify(string notifyText);
    void Query(string queryText);
  }
}
