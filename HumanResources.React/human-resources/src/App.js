import React,  {Component} from 'react';
import './App.css';
import { Route, BrowserRouter } from 'react-router-dom';
import Employees from './components/Employees/Employees';
import Candidates from './components/Candidates/Candidates';
import Navbar from './components/Navbar/Navbar';

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
        <div className="title"><h1>Human Resourses Portal</h1></div>
        <div className="table-users">
          <div className="header">
            <Navbar />
          </div>
          <Route path='/employees' render={() => <Employees employees={employees}/>} />
          <Route path='/candidates' render={() => <Candidates candidates={candidates}/>} />
        </div>
      </BrowserRouter>
    )
  }
}