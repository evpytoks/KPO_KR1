using System;
namespace KPO_KR;

public abstract class Database<T>
{
	protected List<T> Data_;

	public Database()
	{
		Data_ = new List<T>();
	}

    public int Create(List<Object> createArguments)
    {
        T newData = CreateInternal(createArguments);
        Data_.Add(newData);
        return GetId(newData);
    }

    public void ChangeStringInfo(int id, string newInfo)
    {
        T data = FindById(id);
        ChangeStringInfoInternal(data, newInfo);
    }

    public void Delete(int id)
    {
        T data = FindById(id);
        Data_.Remove(data);
    }

    public abstract T FindById(int id);
    protected abstract T CreateInternal(List<Object> createArguments);
    protected abstract int GetId(T dataObject);
    protected abstract void ChangeStringInfoInternal(T data, string newInfo);
}

