using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace KPO_KR;

public class Bank
{
    private static readonly Lazy<Bank> instance = new Lazy<Bank>(() => new Bank());

    public static Bank Instance => instance.Value;

    private BankAccountsManager BankAccounts_;
    private CategoriesManager Categories_;
    private OperationsManager Operations_;

    private Bank()
    {
        BankAccounts_ = new BankAccountsManager();
        Categories_ = new CategoriesManager();
        Operations_ = new OperationsManager();
    }

    public int CreateBankAccount(String name)
    {
        List<Object> args = new List<Object> { name };
        return BankAccounts_.Create(args);
    }

    public void ChangeBankAccountName(int id, string newName)
    {
        BankAccounts_.ChangeStringInfo(id, newName);
    }

    public void DeleteBankAccount(int id)
    {
        BankAccounts_.Delete(id);
    }

    public int CreateCategory(String name, OperationType type)
    {
        List<Object> args = new List<Object> { type, name };
        return Categories_.Create(args);
    }

    public void ChangeCategoryName(int id, string newName)
    {
        Categories_.ChangeStringInfo(id, newName);
    }

    public void DeleteCategory(int id)
    {
        Categories_.Delete(id);
    }

    public int CreateOperation(int bankAccountId, int categoryID, int amount, string date, string description)
    {
        List<Object> args = new List<Object> { bankAccountId, categoryID, amount, date, description };
        BankAccounts_.FindById(bankAccountId).Balance_ += amount;
        return Operations_.Create(args);
    }

    public void ChangeOperationDescription(int id, string newDescription)
    {
        Operations_.ChangeStringInfo(id, newDescription);
    }

    public void DeleteOperation(int id)
    {
        Operation operation = Operations_.FindById(id);
        BankAccounts_.FindById(operation.BankAccountID_).Balance_ += operation.Amount_;
        Operations_.Delete(id);
    }

    public Category GetCategory(int id)
    {
        return Categories_.FindById(id);
    }
}