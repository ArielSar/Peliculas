﻿function pruebaPuntoNetStatic() {
    DotNet.invokeMethodAsync("BlazoBlazorPeliculas.Client", "ObtenerCurrentCount" )
        .then(
            resultado => {
                            console.log("Conteo desde JS " + resultado);
            }
        );
}

function pruebaPuntoNetInstancia(dotnetHelper)
    {

    dotnetHelper.invokeMethodAsync("IncrementCount");
}