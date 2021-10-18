namespace TheRuhuahs_TandTNew.Services
{
    public class TouristCenterService : ITouristCenterService
    {
        private readonly ITouristCenterRepository _touristCenterRepository;

        public TouristCenterService(ITouristCenterRepository touristCenterRepository)
        {
            _touristCenterRepository = touristCenterRepository;
        }

        public TouristCenter AddTouristCenter(CreateTouristCenterViewModel model)
        {
          
            var touristCenter = new TouristCenter
            {
                Name = model.Name,
                Location = model.Location,
                Address = model.Address,
                TouristCenterPictureUrl = model.TouristCenterPictureUrl

            };
          
            return _touristCenterRepository.AddTouristCenter(touristCenter);
        }
        public TouristCenter UpdateTouristCenter(UpdateTouristCenterViewModel model)
        {
            var touristCenter = new TouristCenter
            {
                Name = model.Name,
                Location = model.Location,
                Address = model.Address,
                TouristCenterPictureUrl = model.TouristCenterPictureUrl

            };
            return _touristCenterRepository.UpdateTouristCenter(touristCenter);
        }

        public TouristCenter FindByTouristCenterId(int id)
        {
            return _touristCenterRepository.FindByTouristCenterId(id);
        }

        public void DeleteTouristCenter(int id)
        {
            _touristCenterRepository.DeleteTouristCenter(id);
        }
        public List<TouristCenterViewModel> GetTouristCenter()
        {
            var touristCenter = _touristCenterRepository.GetTouristCenter().Select(c => new TouristCenterViewModel
            {
                Id = c.Id,
                Name = c.Name,
                Location = c.Location,
                Address = c.Address,
                TouristCenterPictureUrl = c.TouristCenterPictureUrl
               
            }).ToList();

            return touristCenter;
        
        }
}