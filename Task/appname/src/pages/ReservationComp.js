import React, { useEffect, useState } from 'react';
import axios from 'axios';
import 'bootstrap/dist/css/bootstrap.min.css';

const ReservationComp = () => {
  const [data, setData] = useState(null);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState(null);

  useEffect(() => {
    axios.get('http://localhost:5227/Api/Reservation')
      .then(response => {
        setData(response.data);
        setLoading(false);
      })
      .catch(error => {
        setError(error.response?.data?.message || error.message || 'Error fetching data');
        setLoading(false);
      });
  }, []);

  if (loading) return <p className="text-center">Loading...</p>;
  if (error) return <p className="text-center text-danger">{error}</p>;

  if (!data || (Array.isArray(data) && data.length === 0)) return <p className="text-center">No data available.</p>;

  return (
    <div className="container mt-4">
      <h2 className="text-center mb-4">Booked Reservations</h2>
      <table className="table table-striped table-bordered">
        <thead className="thead-dark">
          <tr>
            <th>Id</th>
            <th>Name</th>
            <th>Start Location</th>
            <th>End Location</th>
          </tr>
        </thead>
        <tbody>
          {Array.isArray(data) ? (
            data.map(reservation => (
              <tr key={reservation.id}>
                <td>{reservation.id}</td>
                <td>{reservation.name}</td>
                <td>{reservation.startLocation}</td>
                <td>{reservation.endLocation}</td>
              </tr>
            ))
          ) : (
            <tr>
              <td colSpan="4" className="text-center">No reservations found.</td>
            </tr>
          )}
        </tbody>
      </table>
    </div>
  );
};

export default ReservationComp;