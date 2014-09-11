namespace TxPms
{
  public interface ResizeListener
  {
    void OnResize(ResizeArgs i_ResizeArgs);
  }

  public class ResizeArgs
  {
    public string FormName;
    public int Left;
    public int Top;
    public int Right;
    public int Botton;
  }
}
