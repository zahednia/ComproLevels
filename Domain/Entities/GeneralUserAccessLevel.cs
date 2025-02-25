namespace Domain.Entities
{
    public class GeneralUserAccessLevel
    {
        public int Id { get; set; }
        public int User_Id { get; set; }
        public int AccessLevel_Id { get; set; }
        public bool AccessView { get; set; }
        public bool AccessNew { get; set; }
        public bool AccessEdit { get; set; }
        public bool AccessDelete { get; set; }
        public bool AccessFirstConfirm { get; set; }
        public bool AccessSecondConfirm { get; set; }
        public bool AccessPrint { get; set; }
    }
}
