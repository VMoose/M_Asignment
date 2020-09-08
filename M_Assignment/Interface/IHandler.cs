namespace M_Assignment.Interface 
{
    public interface IHandler 
    {
        IHandler SetNet(IHandler handler);
        object Handle(object request, float output =0);
    }
}