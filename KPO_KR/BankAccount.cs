using System;
namespace KPO_KR;

public class BankAccount
{
	public int Id_ { get; }
	public String Name_ { get; set; }
	public int Balance_ { get; set; }


	private BankAccount(int id, string name)
	{
		Id_ = id;
		Name_ = name;
		Balance_ = 0;
	}

	public static BankAccount Create(string name)
	{
		int id = IdGenerator.GetNextId<BankAccount>();
		return new BankAccount(id, name);
    }
}

