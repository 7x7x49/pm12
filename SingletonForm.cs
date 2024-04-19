namespace active_way
{
    public class SingletonForm
    {
        private static SingletonForm instance; //паттерн для создания одиночного объекта формы
        private WinMain wc;

        public static SingletonForm Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SingletonForm();
                }
                return instance;
            }
        }

        private SingletonForm()
        {
            wc = new WinMain();
        }
        public WinMain Controls
        {
            get { return wc; }
        }
    }
}
