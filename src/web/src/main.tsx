import React from 'react'
import ReactDOM from 'react-dom/client'
import { Auth0Provider } from '@auth0/auth0-react'
import App from './App.tsx'
import './index.css'

ReactDOM.createRoot(document.getElementById('root')!).render(
  <Auth0Provider
  domain="violet-mask.us.auth0.com"
  clientId="gj0Z7lEUBtJBeM2fNqEj0IYapRyxwE8k"
  authorizationParams={{
    redirect_uri: window.location.origin
  }}
  >
  <React.StrictMode>
    <App />
  </React.StrictMode>,
  </Auth0Provider>
)
