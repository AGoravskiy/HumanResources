import React from 'react';
import style from './Employees.module.css';
import * as dateService from '../../../dateService.js'

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
                        <td>{dateService.formatDate(employee.DateOfBirth)}</td>
                        <td>{dateService.formatDate(employee.StartDate)}</td>
                    </tr>
                )}
        </table>
    );
}

export default Employees;