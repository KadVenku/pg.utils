namespace pg.util.interfaces
{
    public interface IBinaryFileBuilder<out TFileToBuild, in TFileToBuildAttribute>
    {
        TFileToBuild Build(byte[] bytes);
        TFileToBuild Build(TFileToBuildAttribute attribute);
    }
}
