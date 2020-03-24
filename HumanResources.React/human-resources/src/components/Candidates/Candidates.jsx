import React from 'react';
import './Candidates.module.css';

function formatDate(date) {
    var jsDate = new Date(Date.parse(date));
    return jsDate.toLocaleDateString();
}

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
                        <td>{formatDate(candidate.DateOfBirth)}</td>
                    </tr>
                )}
        </table>
    );
}

export default Candidates;
