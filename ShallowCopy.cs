//extension method to do a shallow copy of object
public class BaseClass
{
  public T ShallowCopy<T>() where T : BaseClass
  {
      return (T)(MemberwiseClone());
  }
}
