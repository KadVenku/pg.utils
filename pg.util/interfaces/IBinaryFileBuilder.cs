namespace pg.util.interfaces
{
    public interface IBinaryFileBuilder<out T>
    {
        T Build(byte[] megFileBytes);
        byte[] Build(object payload);
    }
}
