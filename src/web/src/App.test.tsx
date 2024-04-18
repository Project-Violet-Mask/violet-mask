import { render, screen } from '@testing-library/react';
import App from './App';

describe("App component tests", () => {
    test("should show title all the time", () => {

        render(<App/>)

        expect(screen.getByText(/violet mask 3/i))
        .toBeDefined()
    })

    test("should show 'All' link in the menu", () => {

        render(<App/>)

        expect(screen.getByText(/All/i))
        .toBeDefined()
    })
})