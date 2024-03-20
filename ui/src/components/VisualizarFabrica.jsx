
import React from 'react';
import {
  Input,
  Button,
  Flex,
  FormLabel,
  Select,
  Table,
  TableContainer,
  Thead,
  Tbody,
  Tr,
  Th,
  Td,
  AbsoluteCenter,
  Modal,
  //BackgroundImage
} from "@chakra-ui/react";
import axios from 'axios';
import InsertarFabrica  from './InsertarFabrica'
export default class Fabrica extends React.Component {
    state = {
      Fabricas: [],
      insertarFabricaModalAbierto: false,
    }
  
    componentDidMount() {
      axios.get(`http://localhost:5103/api/Fabrica`)
        .then(res => {
          const Fabricas= res.data;
          this.setState({ Fabricas });
        })
    }

    manejarInsertarFabricaModal = () => {
      this.setState({ insertarFabricaModalAbierto: true });
    };
  
  
    render() {
      return (
        <div style={{height : 400}}>
          <AbsoluteCenter top={"80px"} left={"550px"}>
          <Button
         onClick={this.manejarInsertarFabricaModal}
         marginBottom={5}
         marginTop={5}
         >
          Agregar Fabrica
         </Button>
         <Modal isOpen={this.state.insertarFabricaModalAbierto} onClose={() => this.setState({ insertarFabricaModalAbierto: false })}>
         <AbsoluteCenter>
         <InsertarFabrica onClose={() => this.setState({ insertarFabricaModalAbierto: false })} />
         </AbsoluteCenter>
         </Modal>
        <TableContainer>
        <Table>
          <Thead>
            <Tr>
              <Th>ID</Th>
              <Th>Nombre</Th>
            </Tr>
          </Thead>
          <Tbody>
            {
              this.state.Fabricas.map((b) => (
                <Tr key={b.FabricaId}>
                  <Td>{b.fabricaId}</Td>
                  <Td>{b.nombre}</Td>
                </Tr>
              )
              )
            }
          </Tbody>
        </Table>
      </TableContainer>
      </AbsoluteCenter>
      </div>
        // <ul>
          // { this.state.Fabricas.map(equipo => <li key={equipo.equipoId}> Id:{equipo.equipoId} Tipo: {equipo.tipoEId} Sede: {equipo.sedeId} </li>)}
        // </ul>
      )
    }
  } 