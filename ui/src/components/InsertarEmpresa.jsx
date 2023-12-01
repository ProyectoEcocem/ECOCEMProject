import { useState, fetch } from "react";
import {
    FormControl,
    FormLabel,
    Input,
    Button,
    Flex,
    //BackgroundImage
  } from "@chakra-ui/react"; 
import axios from "axios";

const InsertarEmpresa = () => {
    const [numeroEmpresa, setNumeroEmpresa] = useState("");
    const [nombreEmpresa, setNombreEmpresa] = useState("");


    return (
        <div style={{
          width: "400px",
          height: "400px",
          display: "flex",
          justifyContent: "center",
          alignItems: "center",
          backgroundColor: "white",
          flexDirection: "column",
          borderRadius: 20,
          border: "2px solid #5F89C1",
        }}>
         
    <FormLabel style={{fontSize: 30}}>
      Insertar Empresa
    </FormLabel>
    
      <FormControl>
                  <FormLabel style={{margin: "0px 20px 0px 40px"}}>Número de Empresa</FormLabel>
                  <Input
                    value={numeroEmpresa}
                    placeholder="Ingrese el Número de la Empresa"
                    onChange={(e) => setNumeroEmpresa(e.target.value)}
                    marginTop={0.5}
                    width={80}
                    backgroundColor= "white"
                  />
                </FormControl>
          
                <FormControl>
                  <FormLabel style = {{margin: "20px 0px 0px 40px"}}>Nombre de la Empresa</FormLabel>
                  <Input
                    value={nombreEmpresa}
                    placeholder="Ingrese el nombre de la Empresa"
                    onChange={(e) => setNombreEmpresa(e.target.value)}
                    marginTop={0.5}
                    width={80}
                    backgroundColor= "white"
                  />
                </FormControl>
    
            <Flex>
            <Button variant="contained" color="primary" style={{ marginRight: 10}}>
              Aceptar
            </Button>
            <Button variant="contained" color="secondary">
              Cancelar
            </Button>
            </Flex>
          </div>
      );

};

export default InsertarEmpresa;