import React,  {Component} from 'react';
import './App.css';
import { Route, BrowserRouter } from 'react-router-dom';
import { NavLink } from 'react-router-dom';
import * as dateService from './dateService.js'


/* Navbar component */
const Navbar = () => {
    return (
        <ul className="menu">
            <li className="link">
                <NavLink activeClassName="active" to='/employees'>
                    Employees
                </NavLink>
            </li>
            <li className="link">
                <NavLink activeClassName="active" to='/candidates'>
                    Candidates
                </NavLink>
            </li>
        </ul>
    );
}


/* Employees component */
const Employees = (props) => {
    return (
        <table className="list" cellSpacing="0">
            <thead>
                <tr>
                    <th>Name</th>
                    <th>Position</th>
                    <th>Email</th>
                    <th>Phone</th>
                    <th>DateOfBirth</th>
                    <th>StartDate</th>
                </tr>
            </thead>
            <tbody>
                {props.employees.map((employee, i) =>
                    <tr key={i}>
                        <td>{employee.Name}</td>
                        <td>{employee.Position}</td>
                        <td>{employee.Email}</td>
                        <td>{employee.Phone}</td>
                        <td>{dateService.formatDate(employee.DateOfBirth)}</td>
                        <td>{dateService.formatDate(employee.StartDate)}</td>
                    </tr>
                )}
            </tbody>
        </table>
    );
}


/* Candidates component */
const Candidates = (props) => {
    return (
        <table className="list" cellSpacing="0">
            <thead>
                <tr>
                    <th>Name</th>
                    <th>Position</th>
                    <th>Email</th>
                    <th>Phone</th>
                    <th>DateOfBirth</th>
                </tr>
            </thead>
            <tbody>
                {props.candidates.map((candidate, i) =>
                    <tr key={i}>
                        <td>{candidate.Name}</td>
                        <td>{candidate.Position}</td>
                        <td>{candidate.Email}</td>
                        <td>{candidate.Phone}</td>
                        <td>{dateService.formatDate(candidate.DateOfBirth)}</td>
                    </tr>
                )}
            </tbody>
        </table>
    );
}


export class App extends Component {

  constructor(props) {
    super(props);
    this.state = {
      employees: [],
      candidates: []
    }
  }

  componentDidMount(){
    this.refreshList();
  }

  refreshList() {
    fetch('https://localhost:44311/api/employees').then(response => response.json()).then(data => { this.setState({ employees: data }) });
    fetch('https://localhost:44311/api/candidates').then(response => response.json()).then(data => { this.setState({ candidates: data }) });
  }

  render() {
    const {employees, candidates} = this.state;
    return (
      <BrowserRouter>
        <div>
            <div className="title"><h1>Human Resourses Portal</h1></div>
            <div className="table-users">
                <div className="header">
                    <Navbar />
                </div>
                <Route path='/employees' render={() => <Employees employees={employees} />} />
                <Route path='/candidates' render={() => <Candidates candidates={candidates} />} />
            </div>
        </div>
      </BrowserRouter>
    )
  }
}

