function pruebaPuntoNetStatic() {
    DotNet.invokeMethodAsync("BlazorWA.Client", "ObtenerCurrentCount")
        .then(resultado => {
            console.log("Conteo desde JS: " + resultado);
        });
}

function pruebaPuntoNetInstancia(dotnetHelper) {
    //si el metodo retornara algo se usa el them como en el metodo pasado
    dotnetHelper.invokeMethodAsync("IncrementCount");
}