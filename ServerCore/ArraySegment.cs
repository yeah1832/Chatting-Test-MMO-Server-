namespace ServerCore
{
    internal class ArraySegment
    {
        private byte[] buff;
        private int v;
        private int length;

        public ArraySegment(byte[] buff, int v, int length)
        {
            this.buff = buff;
            this.v = v;
            this.length = length;
        }
    }
}