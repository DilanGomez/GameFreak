namespace pokemones.equipo;

interface IPokemones
{
    void add(pokemonesTDO pokemones);
    void Delete(string Nombre);

    void Update(string Nombre,pokemonesTDO pokemones);

    List<pokemonesTDO>all();
}