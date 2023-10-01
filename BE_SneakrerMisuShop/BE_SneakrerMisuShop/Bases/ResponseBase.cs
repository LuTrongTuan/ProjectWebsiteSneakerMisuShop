namespace BE_SneakrerMisuShop.Bases
{
    public class ResponseBase<T>
    {
        public T data { get; set; }
        public int status { get; set; }
    }
}
