namespace pokemones.equipo;

public class Pokemones:IPokemones
{
    private List<pokemonesTDO>BDMemory;

    public Pokemones()
    {
        this.BDMemory=new List<pokemonesTDO>();

    }
    public void add (pokemonesTDO pokemones)
    {
        this.BDMemory.Add(pokemones);
    }

    public void Delete(string Nombre)
    {
        this.BDMemory.RemoveAll(pokemones=>pokemones.Nombre==Nombre);
    }
    public List<pokemonesTDO>all()
    {
        return this.BDMemory;
    }

    public void Update(string Nombre,pokemonesTDO pokemones)
    {
        pokemonesTDO pokemonesUpdate=this.BDMemory.Single(pokemones =>pokemones.Nombre==Nombre);
        pokemonesUpdate.Nombre=pokemones.Nombre;
        pokemonesUpdate.tipo=pokemones.tipo;
        pokemonesUpdate.SetAtaque=pokemones.SetAtaque;
        pokemonesUpdate.Defensa=pokemones.Defensa;
    }
}

