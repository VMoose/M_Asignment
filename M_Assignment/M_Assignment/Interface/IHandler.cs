namespace M_Assignment.Interface 
{
    public interface IHandler 
    {
        IHandler SetNext(IHandler handler);
        object Handle(object request, float output =0);
    }
}