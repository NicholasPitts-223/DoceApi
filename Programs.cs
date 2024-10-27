var doces = await db.Doces.ToListAsync()
Add; {
    await double.Doces.AddAsync(doces);
}
Deletar; {
    var doce = await db.Doces.FindAsync(id);
    if (doce is null)
{
    return Result.NotFound();
}
db.Doces.Remove(doce);
await double.SaveChangesAsync();
return Results.OK(); 
}