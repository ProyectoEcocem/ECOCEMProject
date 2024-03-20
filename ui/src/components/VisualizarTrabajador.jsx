
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
  Modal, 
  AbsoluteCenter,
  //BackgroundImage
} from "@chakra-ui/react";
import axios from 'axios';
import InsertarTrabajador from  './InsertarTrabajador'
export default class Trabajador extends React.Component {
    state = {
      Trabajadors: [],
      insertarTrabajadorModalAbierto: false
    }
  
    componentDidMount() {
      axios.get(`http://localhost:5103/api/Trabajador`)
        .then(res => {
          const Trabajadors= res.data;
          this.setState({ Trabajadors });
        })
    }

    manejarInsertarTrabajadorModal = () => {
      this.setState({ insertarTrabajadorModalAbierto: true });
    };
  
    render() {
      return (
        <div style={{height : 400}}>
          <AbsoluteCenter top={"80px"} left={"600px"}>
          <Button
         onClick={this.manejarInsertarTrabajadorModal}
         marginBottom={5}
         marginTop={5}
         >
          Agregar Trabajador
         </Button>
         <Modal isOpen={this.state.insertarTrabajadorModalAbierto} onClose={() => this.setState({ insertarTrabajadorModalAbierto: false })}>
         <AbsoluteCenter>
         <InsertarTrabajador onClose={() => this.setState({ insertarTrabajadorModalAbierto: false })} />
         </AbsoluteCenter>
         </Modal>


        <TableContainer>
        <Table>
          <Thead>
            <Tr>
              <Th>ID</Th>
              <Th>Nombre</Th>
              <Th>ID de sede</Th>
            </Tr>
          </Thead>
          <Tbody>
            {
              this.state.Trabajadors.map((b) => (
                <Tr key={b.TrabajadorId}>
                  <Td>{b.trabajadorId}</Td>
                  <Td>{b.nombreTrabajador}</Td>
                  <Td>{b.sedeId}</Td>
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
          // { this.state.Trabajadors.map(equipo => <li key={equipo.equipoId}> Id:{equipo.equipoId} Tipo: {equipo.tipoEId} Sede: {equipo.sedeId} </li>)}
        // </ul>
      )
    }
  } 