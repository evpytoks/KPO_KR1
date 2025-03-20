using System;
namespace KPO_KR;

public class OperationsManager : Database<Operation>
{
    public override Operation FindById(int id)
    {
        return Data_.FirstOrDefault(e => e.Id_ == id);
    }

    protected override Operation CreateInternal(List<Object> createArguments)
    {
        return Operation.Create((int)createArguments[0], (int)createArguments[1], (int)createArguments[2], (string)createArguments[3], (string)createArguments[4]);
    }

    protected override int GetId(Operation dataObject)
    {
        return dataObject.Id_;
    }

    protected override void ChangeStringInfoInternal(Operation data, string newInfo)
    {
        data.Description_ = newInfo;
    }
}

