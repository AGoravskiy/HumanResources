import React from 'react';
import style from './Employees.module.css';


function formatDate(date) {
    var jsDate = new Date(Date.parse(date));
    return jsDate.toLocaleDateString();
}


const Employees = (props) => {
    return (
        <table cellSpacing="0">
            <tr>
                <th>Name</th>
                <th>Position</th>
                <th>Email</th>
                <th>Phone</th>
                <th>DateOfBirth</th>
                <th>StartDate</th>
            </tr>
                {props.employees.map(employee =>
                    <tr>
                        <td>{employee.Name}</td>
                        <td>{employee.Position}</td>
                        <td>{employee.Email}</td>
                        <td>{employee.Phone}</td>
                        <td>{formatDate(employee.DateOfBirth)}</td>
                        <td>{formatDate(employee.StartDate)}</td>
                    </tr>
                )}
        </table>
    );
}

export default Employees;