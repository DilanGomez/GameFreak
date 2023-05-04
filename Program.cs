using pokemones.equipo;


var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<pokemonesTDO>BDMemory=new List<pokemonesTDO>();



app.MapPost("/api/v1/equipo/pokemon", (pokemonesTDO esData) => {
    BDMemory.Add(esData);
});

app.MapPost("/api/v1/equipo/multiples",(pokemonesTDO[] esData)=>{

    foreach(pokemonesTDO esDate in esData )
    {
        BDMemory.Add(esDate);
    }});






app.MapPut("/api/v1/equipo/{Nombre}/pokemones", (string Nombre, pokemonesTDO esData) => {
    pokemonesTDO updateEsT = BDMemory.Single(item => item.Nombre == Nombre);

    foreach(int SetAtaque in esData.SetAtaque){
        if(updateEsT.SetAtaque.IndexOf(SetAtaque) == -1){
            updateEsT.SetAtaque.Add(SetAtaque);
        }
    }
});

app.MapDelete("/api/v1/equipo/pokemon/{Nombre}", (string Nombre) => {return Results.Ok(BDMemory.RemoveAll(pokemones => pokemones.Nombre ==Nombre));});





app.MapGet("/api/v1/equipo/pokemones", () => {return Results.Ok(BDMemory);});




app.Run();


