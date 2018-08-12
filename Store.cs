using System;

public class Store
{
    public Reducer State
    {
        get; private set;
    }

    private IListener _listeners;

	public Store()
	{
        _listeners = new List<IListener>();
	}

    public void Subscribe()
    {

    }

    public void Unsubscribe()
    {

    }
}
