namespace Task1
{

    class Door
    {
        public bool IsDoorOpen { get; set; }

        public void SwitchState()
        {
            IsDoorOpen = !IsDoorOpen;
        }
    }
}
