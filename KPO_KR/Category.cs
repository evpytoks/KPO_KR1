using System;
namespace KPO_KR;

public class Category
{
    public int Id_ { get; }
    public OperationType Type_ { get; private set; }
    public String Name_ { get; set; }

    public Category(int id, OperationType type, string name)
	{
        Id_ = id;
        Type_ = type;
        Name_ = name;
    }

    public static Category Create(OperationType type, string name)
    {
        int id = IdGenerator.GetNextId<Category>();
        return new Category(id, type, name);
    }
}

