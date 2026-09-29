namespace SerieA.Api.Entities.Enums
{
    public enum MatchStatus
    {
        Scheduled,  // Oynanacak
        Live,       // Şu anda oynanıyor
        Finished,   // Tamamlandı
        Postponed,  // Ertelendi
        Cancelled  // İptal edildi
    }
}
