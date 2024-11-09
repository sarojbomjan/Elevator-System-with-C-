namespace Elevator
{
    public interface ILiftState
    {
        void MoveUp(Lift lift);
        void MoveDown(Lift lift);
     
    }
}
