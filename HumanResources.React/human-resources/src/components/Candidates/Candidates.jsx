import React from 'react';
import './Candidates.module.css';
import * as dateService from './../../dateService.js'

const Candidates = (props) => {
    return (
        <table cellSpacing="0">
            <tr>
                <th>Name</th>
                <th>Position</th>
                <th>Email</th>
                <th>Phone</th>
                <th>DateOfBirth</th>
            </tr>
                {props.candidates.map(candidate =>
                    <tr>
                        <td>{candidate.Name}</td>
                        <td>{candidate.Position}</td>
                        <td>{candidate.Email}</td>
                        <td>{candidate.Phone}</td>
                        <td>{dateService.formatDate(candidate.DateOfBirth)}</td>
                    </tr>
                )}
        </table>
    );
}

export default Candidates;
