// Define
public class SingletonDemoClass: Singleton<SingletonDemoClass>
{
    public void DoSomething() {}
}

// Somewhere in other class
public class OtherClass 
{
    public void SomeMethod()
    {
        SingletonDemoClass.Instance.DoSomething();
    }
}