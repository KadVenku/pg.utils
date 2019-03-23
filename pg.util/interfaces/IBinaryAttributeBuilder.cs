namespace pg.util.interfaces
{
    public interface IBinaryAttributeBuilder<out T>
    {
        T Build(byte[] bytes);
    }
}
