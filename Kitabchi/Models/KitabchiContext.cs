namespace Kitabchi.Models
{
    using Kitabchi_Project.Models;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public partial class KitabchiContext : IdentityDbContext
    {
        public KitabchiContext(DbContextOptions<KitabchiContext>options)
            : base(options)
        {
        }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<CommentToProduct> CommentToProducts { get; set; }
        public virtual DbSet<OfferToImage> OfferToImages { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Genre_To_Product> Genre_To_Product { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<LanguageResource> LanguageResources { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<Offer> Offers { get; set; }
        public virtual DbSet<OrderHistory> OrderHistories { get; set; }
        public virtual DbSet<OrderItem> OrderItems { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Promo> Promos { get; set; }
        public virtual DbSet<Shop_To_Products> Shop_To_Products { get; set; }
        public virtual DbSet<Shop> Shops { get; set; }
        public virtual DbSet<Slider> Sliders { get; set; }
        public virtual DbSet<SliderToImage> SliderToImages { get; set; }
        public virtual DbSet<SocialLink> SocialLinks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
