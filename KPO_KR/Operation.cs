using System;
namespace KPO_KR;

public class Operation
{
    public int Id_ { get; }
    public int BankAccountID_ { get; }
    public int CategoryID_ { get; }
    public OperationType Type_ { get; private set; }
    public int Amount_ { get; private set; }
    public string Date_ { get; private set; }
    public string Description_ { get; set; }

    public Operation(int id, int bankAccountId, int categoryID, OperationType type, int amount, string date, string description)
	{
        Id_ = id;
        BankAccountID_ = bankAccountId;
        CategoryID_ = categoryID;
        Type_ = type;
        Amount_ = amount;
        Date_ = date;
        Description_ = description;
    }

    public static Operation Create(int bankAccountId, int categoryID, int amount, string date, string description)
    {   if (!IdGenerator.CheckId<BankAccount>(bankAccountId) || !IdGenerator.CheckId<Category>(categoryID)) {
            throw new Exception();
        }

        int id = IdGenerator.GetNextId<Operation>();
        OperationType type = Bank.Instance.GetCategory(categoryID).Type_;
        return new Operation(id, bankAccountId, categoryID, type, amount, date, description);
    }
}

