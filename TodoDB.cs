using Microsoft.EntityFrameworkCore;

class TodoDB: DbContext {
  public TodoDB (DbContextOptions options): base(options) {}

  public DbSet<Todo> Todos => Set<Todo>();
}