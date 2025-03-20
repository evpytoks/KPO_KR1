using System;
namespace KPO_KR;

public class CategoriesManager : Database<Category>
{
    public override Category FindById(int id)
    {
        return Data_.FirstOrDefault(e => e.Id_ == id);
    }

    protected override Category CreateInternal(List<Object> createArguments)
    {
        return Category.Create((OperationType)createArguments[0], (string)createArguments[1]);
    }

    protected override int GetId(Category dataObject)
    {
        return dataObject.Id_;
    }

    protected override void ChangeStringInfoInternal(Category data, string newInfo)
    {
        data.Name_ = newInfo;
    }
}

