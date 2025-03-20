using System;
namespace KPO_KR;

public class BankAccountsManager : Database<BankAccount>
{
    public override BankAccount FindById(int id)
    {
        return Data_.FirstOrDefault(e => e.Id_ == id);
    }

    protected override BankAccount CreateInternal(List<Object> createArguments)
    {
        return BankAccount.Create((string) createArguments[0]);
    }

    protected override int GetId(BankAccount dataObject)
    {
        return dataObject.Id_;
    }

    protected override void ChangeStringInfoInternal(BankAccount data, string newInfo)
    {
        data.Name_ = newInfo;
    }
}

