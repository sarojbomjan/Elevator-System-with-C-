namespace Elevator

{
    public interface IDoorState
    {
        void OpeningDoor(Door door);

        void ClosingDoor(Door door);
    }
}
